clc; clear all; close all;


%%DATABASE CONNECTIVITY is begining

%Set preferences with setdbprefs.
setdbprefs('DataReturnFormat', 'cellarray');

%Make connection to database.  Note that the password has been omitted.
%Using JDBC driver.
conn = database('ATM_Fingerprint', '', '', 'Vendor', 'MICROSOFT SQL SERVER',...
                'Server', 'PARASGARG-HP', 'PortNumber', 1433, 'AuthType',...
                'Windows');

%SQL Queries are written to fetch information from database
%SQL Queries are written to fetch original image name from database
query_original = 'SELECT Original_Finger FROM tbl_matlab_temp';
%SQL Queries are written to fetch temp image name from database
query_temp = 'SELECT Temp_Finger FROM tbl_matlab_temp';

%Read data from database
%Reading original image name from database
curs = exec(conn, query_original);
curs = fetch(curs);
original = curs.Data;
%Reading temp image name from database
curs = exec(conn, query_temp);
curs = fetch(curs);
temp = curs.Data;

%Converting the value from CELL to STRING
%Converting Original image path
original = char (original);
%Converting Temp image path
temp = char (temp);

%Removing unwanted variables from the workspace
clear query_original;
clear query_temp;
clear curs;


%%MATCHING ALGORITHM is begining

%Storing images into a variables from specified path in database
%Storing image of original fingerprint
original_pic = imread(original);
%Storing image of temp fingerprint
temp_pic = imread(temp);

%Removing unwanted variables from the workspace
clear original;
clear temp;

%Showing fetched images in sub-graphs
figure
subplot(1,2,1);
imshow(original_pic)
subplot(1,2,2);
imshow(temp_pic)


%Converting a regular image into a binary image
%Binary image is the image which saves in 0 & 1 inside the matrix
%Converting original picture into binary image
original_pic_bw = im2bw(original_pic, 0.5);
%Coverting temp picture into binary image
temp_pic_bw = im2bw(temp_pic, 0.5);


%Applying process of thinning
%Thinning improve to notify the miutiae extraction
%Thinning is applied on original binary image
original_pic_thin = bwmorph(original_pic_bw,'thin','Inf');
%Thinning is applied on temp binary image
temp_pic_thin = bwmorph(temp_pic_bw,'thin','Inf');

%Showing difference between images in sub-graphs
figure
subplot(1,3,1);
imshow(original_pic)        %Original picture the captured
subplot(1,3,2); 
imshow(original_pic_bw)     %Binary image of original picture
subplot(1,3,3);
imshow(original_pic_thin)   %Thinned of binary image of original picture

%So that we obtain white and black points and edges of the objects present
%in the picture.
%Applying edge detection on original picture
edge_det_original = edge(original_pic_thin,'prewitt');


%So that we obtain white and black points and edges of the objects present
%in the picture.
%Applying edge detection on temp picture
edge_det_temp = edge(temp_pic_thin,'prewitt');

%Showing processed images in sub-graphs
figure
subplot(1,2,1);
imshow(edge_det_original)
subplot(1,2,2);
imshow(edge_det_temp)

%Saving the messages which shoud be shown on screen
OUTPUT_MESSAGE = 'Hence the pictures have been matched, SAME PICTURES';
OUTPUT_MESSAGE2 = 'Hence the pictures have not been matched, DIFFERENT PICTURES';

%Initialization of different variables used
matched_data = 0;
white_points = 0;
black_points = 0;

%For loop used for detecting black and white points in the picture.
for i = 1:1:256
    for j = 1:1:256
        if(edge_det_original(i,j)==1)
            white_points = white_points+1;
        else
            black_points = black_points+1;
        end
    end
end

%For loop comparing the white (edge points) in the two pictures
for i = 1:1:256
    for j = 1:1:256
        if(edge_det_original(i,j)==1)&&(edge_det_temp(i,j)==1)
            matched_data = matched_data+1;
        end
    end
end
   
%Calculating percentage matching.
total_data = white_points;
total_matched_percentage = (matched_data/total_data)*100;

%Removing unwanted variables from the workspace
clear matched_data;
clear white_points;
clear black_points;

%UPDATING DATABASE as per the image processing result in MATCHED column
colnames = {'Matched'};
result_false(1,1) = {'No'};
result_true(1,1) = {'Yes'};
whereClause = '';


%Outputting the result of the system.
if(total_matched_percentage >= 90)          %can add flexability at this point by reducing the amount of matching. 
   
    update(conn, 'tbl_matlab_temp', colnames, result_true, whereClause);
    
    total_matched_percentage;       %for the output in the end remove
    OUTPUT_MESSAGE;                 % semicolons (';') in the ends
else
   
    update(conn, 'tlb_matlab_temp', colnames, result_false, whereClause);
   
    total_matched_percentage;
    OUTPUT_MESSAGE2;
end