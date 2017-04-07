clc; clear all; close all;

pic1 = imread('d:\1.bmp');
pic2 = imread('d:\1.bmp');

figure
subplot(1,2,1);
imshow(pic1)
subplot(1,2,2);
imshow(pic2)

%so that we obtain white and black points and edges of the objects present
%in the picture.

edge_det_pic1 = edge(pic1,'prewitt');%applying edge detection on first picture


%so that we obtain white and black points and edges of the objects present
%in the picture.

edge_det_pic2 = edge(pic2,'prewitt');%%applying edge detection on second picture

figure
subplot(1,2,1);
imshow(edge_det_pic1)
subplot(1,2,2);
imshow(edge_det_pic2)


OUTPUT_MESSAGE = ' Hence the pictures have been matched, SAME PICTURES ';

OUTPUT_MESSAGE2 = ' Hence the pictures have not been matched, DIFFERENT PICTURES ';

%initialization of different variables used
matched_data = 0;
white_points = 0;
black_points = 0;
x=0;
y=0;
l=0;
m=0;

%for loop used for detecting black and white points in the picture.
for a = 1:1:256
    for b = 1:1:256
        if(edge_det_pic1(a,b)==1)
            white_points = white_points+1;
        else
            black_points = black_points+1;
        end
    end
end

%for loop comparing the white (edge points) in the two pictures
for i = 1:1:256
    for j = 1:1:256
        if(edge_det_pic1(i,j)==1)&&(edge_det_pic2(i,j)==1)
            matched_data = matched_data+1;
        end
    end
end
   



%calculating percentage matching.
total_data = white_points;
total_matched_percentage = (matched_data/total_data)*100;

%outputting the result of the system.
if(total_matched_percentage >= 90)          %can add flexability at this point by reducing the amount of matching.
   
    total_matched_percentage;
    OUTPUT_MESSAGE;
else
   
    total_matched_percentage;
    OUTPUT_MESSAGE2;
end