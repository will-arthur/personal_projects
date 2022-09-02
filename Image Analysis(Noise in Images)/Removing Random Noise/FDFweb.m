clear all; close all; clc

r2 = (imread('C:\Users\willa\Documents\MATLAB\i/PandaNoise(1).bmp'));
fr2 = fft2(r2);
figure(1);
imshow(log(1+abs(fftshift(fr2))),[]);

m = ones(371, 660);
m(36:1:38,67:1:69) = 0;
m(260:1:262,66:1:68) = 0;
m(334:1:336,66:1:68) = 0;
m(36:1:38,198:1:200) = 0;
m(183:1:186,199:1:201) = 0;
m(335:1:337,199:1:20) = 0;
m(36:1:38,330:1:332) = 0;
m(183:1:185,330:1:332) = 0;
m(333:1:335,328:1:330) = 0;
m(38:1:40,463:1:465) = 0;
m(335:1:337,463:1:465) = 0;
m(39:1:40, 595:1:597) = 0;
m(331:1:333,595:1:597) = 0;
figure(2);imshow(m);

figure(3);imshow(log(1+abs( fftshift(fr2).*m)),[]);
figure(4);imshow(log(1+abs(ifft2( fftshift(fr2).*m))),[]);

m = ones(371, 660);
m(35:1:39,66:1:70) = 0;
m(259:1:263,65:1:69) = 0;
m(333:1:337,65:1:69) = 0;
m(35:1:39,197:1:201) = 0;
m(182:1:187,198:1:202) = 0;
m(334:1:338,198:1:21) = 0;
m(35:1:39,329:1:333) = 0;
m(182:1:186,329:1:333) = 0;
m(332:1:336,327:1:331) = 0;
m(37:1:41,462:1:466) = 0;
m(334:1:338,462:1:466) = 0;
m(38:1:41, 594:1:598) = 0;
m(330:1:334,594:1:598) = 0;
figure(5);imshow(log(1 + abs(fftshift (fr2).*m)), []);
figure(6);imshow (log (1 + abs (ifft2 (fftshift (fr2).*m))), []);
%184-37
%329-184
[X, Y] = meshgrid (1: 660,1: 371)
C = sqrt ((X-331).^2+ (Y-184).^ 2)>= 158 | sqrt ((X-331).^2+ (Y-184).^2) <= 154;
figure(7);imshow (C);
figure(8);imshow (log (1 + abs (fftshift (fr2).*C)), []);
C = sqrt ((X-331).^2+ (Y-184).^ 2)>= 168 | sqrt ((X-331).^2+ (Y-184).^2) <= 165;
figure(9);imshow (log (1 + abs (fftshift (fr2).*C)), []);

C1  = sqrt ((X-331).^2+ (Y-184).^ 2)>= 158 | sqrt ((X-331).^2+ (Y-184).^2) <= 154;

C2 = sqrt ((X-331).^2+ (Y-184).^ 2)>= 168 | sqrt ((X-331).^2+ (Y-184).^2) <= 165;
CS = (C1 + C2)>1;
mesh (CS * 10 + 1);
figure(10);imshow (log (1 + abs (fftshift (fr2).* CS)), []);

figure(11); imshow (log (1 + abs (ifft2 (fftshift (fr2).*C1))), []);
figure(12); imshow (log (1 + abs (ifft2 (fftshift (fr2).*C2))), []);

figure(13); imshow (log (1 + abs (ifft2 (fftshift (fr2).*CS))), []);