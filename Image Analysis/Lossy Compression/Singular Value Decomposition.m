clear all; close all; clc

% Converting from png to jpeg 

S = imread('IC3.png'); %Reading original image
imwrite(S,'IC3.jpg');

% Read in and load in Uncompressed Image
A = imread('IC3.jpg');
figure;imshow(A);title('1.IC3 JPEG IMAGE'); 

%Conerting image into a grayscale image to perform easier SVD 
%and then putting the values of the original image A into I2
I2 = rgb2gray(A);
figure; imshow(I2);title('2.IC3 JPEG IMAGE IN GREYSCALE');

%Converting I2 into double before perfomring SVD function
I3 = im2double(I2);

%Peforming SVD to compress the image
[u,s,v]=svd(I3);
%3024 singular value size
%5%= 151

s2 = s;
s2(152:end, :)=0; 
s2(:, 152:end) = 0;

%12192768
%7057

%Printing the image
D=u*s2*v';
figure;imshow(D);title('3.IC3.JPEG IMAGE AFTER SVG')
imwrite(D,'IC3svd.png');

%Montage
figure;imshowpair(I2,D,'Montage');title('4. Montage for comparison between original greyscale IC3 image and IC3 image after SVD')

%Converting image back to coloured image
Image = imread(D,'IC3svd.png');
if size(Image,3)==3
    Image=rgb2gray(Image);
end
[m n r]=size(Image);
rgb=zeros(m,n,3); 
rgb(:,:,1)=Image;
rgb(:,:,2)=rgb(:,:,1);
rgb(:,:,3)=rgb(:,:,1);
Image=rgb/255; 
figure,imshow(Image);


