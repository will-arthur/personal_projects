clear all; close all; clc

% Converting from png to jpeg 

S = imread('IC1.png'); %Reading original image
imwrite(S,'IC1.jpg');

% Read in and load in Uncompressed Image
A = imread('IC1.jpg');
figure;imshow(A);title('1.IC1 JPEG IMAGE'); 

%Conerting image into a grayscale image to perform easier SVD 
%and then putting the values of the original image A into I2
I2 = rgb2gray(A);
figure; imshow(I2);title('2.IC1 JPEG IMAGE IN GREYSCALE');

%Converting I2 into double before perfomring SVD function
I3 = im2double(I2);

%Peforming SVD to compress the image
[u,s,v]=svd(I3);
%3024 singular value size
%5%= 151

s2 = s;
s2(1059:end, :)=0; 
s2(:, 1059:end) = 0;

%12192768
%7057

%Printing the image
D=u*s2*v';
figure;imshow(D);title('3.IC1.JPEG IMAGE AFTER SVG')
imwrite(D,'IC1svd.png');

%Montage
figure;imshowpair(I2,D,'Montage');title('4. Montage for comparison between original greyscale IC1 image and IC1 image after SVD')