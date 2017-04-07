function varargout = Fingerprint_Authentication_Menu(varargin)
% FINGERPRINT_AUTHENTICATION_MENU MATLAB code for Fingerprint_Authentication_Menu.fig
%      FINGERPRINT_AUTHENTICATION_MENU, by itself, creates a new FINGERPRINT_AUTHENTICATION_MENU or raises the existing
%      singleton*.
%
%      H = FINGERPRINT_AUTHENTICATION_MENU returns the handle to a new FINGERPRINT_AUTHENTICATION_MENU or the handle to
%      the existing singleton*.
%
%      FINGERPRINT_AUTHENTICATION_MENU('CALLBACK',hObject,eventData,handles,...) calls the local
%      function named CALLBACK in FINGERPRINT_AUTHENTICATION_MENU.M with the given input arguments.
%
%      FINGERPRINT_AUTHENTICATION_MENU('Property','Value',...) creates a new FINGERPRINT_AUTHENTICATION_MENU or raises the
%      existing singleton*.  Starting from the left, property value pairs are
%      applied to the GUI before Fingerprint_Authentication_Menu_OpeningFcn gets called.  An
%      unrecognized property name or invalid value makes property application
%      stop.  All inputs are passed to Fingerprint_Authentication_Menu_OpeningFcn via varargin.
%
%      *See GUI Options on GUIDE's Tools menu.  Choose "GUI allows only one
%      instance to run (singleton)".
%
% See also: GUIDE, GUIDATA, GUIHANDLES

% Edit the above text to modify the response to help Fingerprint_Authentication_Menu

% Last Modified by GUIDE v2.5 28-May-2013 22:10:42

% Begin initialization code - DO NOT EDIT
gui_Singleton = 1;
gui_State = struct('gui_Name',       mfilename, ...
                   'gui_Singleton',  gui_Singleton, ...
                   'gui_OpeningFcn', @Fingerprint_Authentication_Menu_OpeningFcn, ...
                   'gui_OutputFcn',  @Fingerprint_Authentication_Menu_OutputFcn, ...
                   'gui_LayoutFcn',  [] , ...
                   'gui_Callback',   []);
if nargin && ischar(varargin{1})
    gui_State.gui_Callback = str2func(varargin{1});
end

if nargout
    [varargout{1:nargout}] = gui_mainfcn(gui_State, varargin{:});
else
    gui_mainfcn(gui_State, varargin{:});
end
% End initialization code - DO NOT EDIT


% --- Executes just before Fingerprint_Authentication_Menu is made visible.
function Fingerprint_Authentication_Menu_OpeningFcn(hObject, ~, handles, varargin)
% This function has no output args, see OutputFcn.
% hObject    handle to figure
% eventdata  reserved - to be defined in a future version of MATLAB
% handles    structure with handles and user data (see GUIDATA)
% varargin   command line arguments to Fingerprint_Authentication_Menu (see VARARGIN)

% Choose default command line output for Fingerprint_Authentication_Menu
handles.output = hObject;

% Update handles structure
guidata(hObject, handles);

% UIWAIT makes Fingerprint_Authentication_Menu wait for user response (see UIRESUME)
% uiwait(handles.fingerprint_gui);

%%DATABASE CONNECTIVITY is begining

%Starting Database Connectivity Code
%%Set preferences with setdbprefs.
setdbprefs('DataReturnFormat', 'cellarray');

%%Make connection to database.  Note that the password has been omitted.
%%Using JDBC driver.
conn = database('ATM_Fingerprint', '', '', 'Vendor', 'MICROSOFT SQL SERVER',...
                'Server', 'PARASGARG-HP', 'PortNumber', 1433, 'AuthType',...
                'Windows');

%%SQL Queries are written to fetch information from database
%SQL Query is written to fetch original image name from database
query_original = 'SELECT Original_Finger FROM tbl_matlab_temp';
%SQL Query is written to fetch temp image name from database
query_temp = 'SELECT Temp_Finger FROM tbl_matlab_temp';

%%Reading data from database
%Reading original image name from database
curs = exec(conn, query_original);
curs = fetch(curs);
original = curs.Data;
%Reading temp image name from database
curs = exec(conn, query_temp);
curs = fetch(curs);
temp = curs.Data;

%The value fetched from the database is in the cell datatype. To use 
%for assigning to other variable, the value should be in appropriate format
%such as should be in string or in int. And to add or update the data in
%the database the value must be in cell datatype.

%%Converting the value from CELL to STRING
%Converting Original image path
original = char (original);
%Converting Temp image path
temp = char (temp);

handles.original = original;
handles.temp = temp;

guidata(hObject, handles);

%Removing unwanted variables from the workspace
clear query_original;
clear query_temp;
clear curs;
clear original;
clear temp;
%Ending Database Connectivity code


% --- Outputs from this function are returned to the command line.
function varargout = Fingerprint_Authentication_Menu_OutputFcn(~, ~, handles) 
% varargout  cell array for returning output args (see VARARGOUT);
% hObject    handle to figure
% eventdata  reserved - to be defined in a future version of MATLAB
% handles    structure with handles and user data (see GUIDATA)

% Get default command line output from handles structure
varargout{1} = handles.output;


% --- Executes on button press in btn_original_figures.
function btn_original_figures_Callback(~, ~, handles) %#ok<DEFNU>
% hObject    handle to btn_original_figures (see GCBO)
% eventdata  reserved - to be defined in a future version of MATLAB
% handles    structure with handles and user data (see GUIDATA)

original_pic = imread (handles.original);
temp_pic = imread (handles.temp);

axes_original = imshow (original_pic);
axes (handles.axes_original)
image (axes_original)

axes_temp = imshow (temp_pic);
axes (handles.axes_temp);

handles.original_pic = original_pic;
handles.temp_pic = temp_pic;

guidata (handles.fingerprint_gui, handles);


% --- Executes on button press in btn_binary.
function btn_binary_Callback(~, ~, handles) %#ok<DEFNU>
% hObject    handle to btn_binary (see GCBO)
% eventdata  reserved - to be defined in a future version of MATLAB
% handles    structure with handles and user data (see GUIDATA)

original_pic_binary = im2bw(handles.original_pic, 0.5);
temp_pic_binary = im2bw(handles.temp_pic, 0.5);

axes_original = imshow (original_pic_binary);
axes (handles.axes_original);
image (axes_original);

axes_temp = imshow (temp_pic_binary);
axes (handles.axes_temp);

handles.original_pic_binary = original_pic_binary;
handles.temp_pic_binary = temp_pic_binary;

guidata (handles.fingerprint_gui,handles);


% --- Executes on button press in btn_thinning.
function btn_thinning_Callback(~, ~, handles)
% hObject    handle to btn_thinning (see GCBO)
% eventdata  reserved - to be defined in a future version of MATLAB
% handles    structure with handles and user data (see GUIDATA)

original_pic_thin = bwmorph(handles.original_pic_binary,'thin','Inf');
temp_pic_thin = bwmorph(handles.temp_pic_binary,'thin','Inf');

axes_original = imshow (original_pic_thin);
axes (handles.axes_original);
image (axes_original);

axes_temp = imshow (temp_pic_thin);
axes (handles.axes_temp);

handles.original_pic_thin = original_pic_thin;
handles.temp_pic_thin = temp_pic_thin;

guidata (handles.fingerprint_gui,handles);


% --- Executes on button press in btn_minutiae.
function btn_minutiae_Callback(~, ~, handles)
% hObject    handle to btn_minutiae (see GCBO)
% eventdata  reserved - to be defined in a future version of MATLAB
% handles    structure with handles and user data (see GUIDATA)

original_pic_minu = edge(handles.original_pic_thin,'prewitt');
temp_pic_minu = edge(handles.temp_pic_thin,'prewitt');

axes_original = imshow (original_pic_minu);
axes (handles.axes_original);
image (axes_original);

axes_temp = imshow (temp_pic_minu);
axes (handles.axes_temp);

handles.original_pic_minu = original_pic_minu;
handles.temp_pic_minu = temp_pic_minu;

guidata (handles.fingerprint_gui,handles);


% --- Executes on button press in btn_histogram.
function btn_histogram_Callback(hObject, ~, handles)
% hObject    handle to btn_histogram (see GCBO)
% eventdata  reserved - to be defined in a future version of MATLAB
% handles    structure with handles and user data (see GUIDATA)

% original_pic_hist = imhist(handles.edge_det_original);
% temp_pic_hist = imhist(handles.edge_det_temp);

original_pic_hist = hist (handles.original_pic_minu);
temp_pic_hist = hist (handles.temp_pic_minu);

axes_original = (original_pic_hist);
axes (handles.axes_original);
image (axes_original);

axes_temp = (temp_pic_hist);
axes (handles.axes_temp);
image (axes_temp);

handles.original_pic_hist = original_pic_hist;
handles.temp_pic_hist = temp_pic_hist;

original_pic_hist = hist (original_pic_minu);
temp_pic_hist = hist (temp_pic_minu);

guidata (hObject,handles);


% --- Executes on button press in btn_exit.
function btn_exit_Callback(~, ~, handles)
% hObject    handle to btn_exit (see GCBO)
% eventdata  reserved - to be defined in a future version of MATLAB
% handles    structure with handles and user data (see GUIDATA)



total_count = 0;
matched_count = 0;

for i = 1:1:10
    for j = 1:1:260
        total_count = total_count + 1;
        
        if (handles.original_pic_hist(i,j) == handles.temp_pic_hist(i,j))
            matched_count = matched_count + 1;
        end
    end
end
    
matched_percent = (matched_count/total_count)*100;


%%Make connection to database.  Note that the password has been omitted.
%%Using JDBC driver.
conn = database('ATM_Fingerprint', '', '', 'Vendor', 'MICROSOFT SQL SERVER',...
                'Server', 'PARASGARG-HP', 'PortNumber', 1433, 'AuthType',...
                'Windows');


%UPDATING DATABASE as per the image processing result in MATCHED column
colname_match = {'Matched'};
colname_percent = {'Matched_Percent'};
result_true(1,1) = {1};
result_false(1,1) = {0};
whereClause = '';

if ( matched_percent > 81)
    update(conn, 'tbl_matlab_temp', colname_match, result_true, whereClause);
    update(conn, 'tbl_matlab_temp', colname_percent, matched_percent, whereClause);
    
else
    update(conn, 'tbl_matlab_temp', colname_match, result_false, whereClause);
    update(conn, 'tbl_matlab_temp', colname_percent, matched_percent, whereClause);
    
end

%Closing the Matlab GUI Application
close(handles.fingerprint_gui);


%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%

function etxt_original_path_Callback(hObject, eventdata, handles)
% hObject    handle to etxt_original_path (see GCBO)
% eventdata  reserved - to be defined in a future version of MATLAB
% handles    structure with handles and user data (see GUIDATA)

% Hints: get(hObject,'String') returns contents of etxt_original_path as text
%        str2double(get(hObject,'String')) returns contents of etxt_original_path as a double


% --- Executes during object creation, after setting all properties.

function etxt_original_path_CreateFcn(hObject, eventdata, handles)
% hObject    handle to etxt_original_path (see GCBO)
% eventdata  reserved - to be defined in a future version of MATLAB
% handles    empty - handles not created until after all CreateFcns called

% Hint: edit controls usually have a white background on Windows.
%       See ISPC and COMPUTER.
if ispc && isequal(get(hObject,'BackgroundColor'), get(0,'defaultUicontrolBackgroundColor'))
    set(hObject,'BackgroundColor','white');
end


function etxt_temp_path_Callback(hObject, eventdata, handles)
% hObject    handle to etxt_temp_path (see GCBO)
% eventdata  reserved - to be defined in a future version of MATLAB
% handles    structure with handles and user data (see GUIDATA)

% Hints: get(hObject,'String') returns contents of etxt_temp_path as text
%        str2double(get(hObject,'String')) returns contents of etxt_temp_path as a double


% --- Executes during object creation, after setting all properties.
function etxt_temp_path_CreateFcn(hObject, eventdata, handles)
% hObject    handle to etxt_temp_path (see GCBO)
% eventdata  reserved - to be defined in a future version of MATLAB
% handles    empty - handles not created until after all CreateFcns called

% Hint: edit controls usually have a white background on Windows.
%       See ISPC and COMPUTER.
if ispc && isequal(get(hObject,'BackgroundColor'), get(0,'defaultUicontrolBackgroundColor'))
    set(hObject,'BackgroundColor','white');
end


% --- Executes when fingerprint_gui is resized.
function fingerprint_gui_ResizeFcn(hObject, eventdata, handles)
% hObject    handle to fingerprint_gui (see GCBO)
% eventdata  reserved - to be defined in a future version of MATLAB
% handles    structure with handles and user data (see GUIDATA)
