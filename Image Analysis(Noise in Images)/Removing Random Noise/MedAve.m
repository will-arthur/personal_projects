clear all; close all; clc

%Shows original PandaNoise image

I = imread('PandaNoise(1).bmp');
figure;imshow(I);title('1. Original Panda Noise');
I2 = im2double(I);

%Removing noise using Average filtering 

Kaverage = filter2(fspecial('average',5),I)/225;
figure;imshow(Kaverage);title('2. Image after average filtering of random noise')

%Removing noise using Median filtering 
Medfilter = medfilt2(I);
figure;imshow(Medfilter);title('3. Image after median filter has been applied')


%Performing both median and then average filtering on the image

Kaveragem = filter2(fspecial('average',5),Medfilter)/225;
figure;imshow(Kaveragem);title('4. Applying both Average and Median filtering')

% Low pass filtering of Guassian white noise 
%5x5 is the most common median filter
k = wiener2(Kaveragem,[5,5]);
figure;imshow(k);title('5. Applying Low pass Wiener filtering');

%Montage to show the difference between when Average filter and Median
%filter are applied to the same image and the orginal noisy image
figure;imshowpair(I,k,'Montage');title('6. Montage for comparison between original noisy image and final after filtering');


%[m n] — Neighborhood size
%[3 3] (default) | 2-element numeric vector of the form [m n]
%Neighborhood size, specified as a 2-element vector [m n] where m is the number of rows and n is the number of columns.
whos I2
whos k
error = immse(I2, k);
fprintf('\n The mean-squared error is %0.4f\n', error);

p = imread('PandaOriginal(1).bmp'); % reading Pandanoriganl
p2 = im2double(p);
error = immse(p2, k);
fprintf('\n The mean-squared error is %0.4f\n', error);



