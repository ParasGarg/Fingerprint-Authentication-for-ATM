function [conn, original, temp] = Database_Connectivity

clc; clear all; close all;

%%DATABASE CONNECTIVITY is begining

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

%Removing unwanted variables from the workspace
clear query_original;
clear query_temp;
clear curs;