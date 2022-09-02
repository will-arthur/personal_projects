a =imread('PandaNoise(1).bmp');

% Compute the 2D fft.  

frequencyImage=fftshift(fft2(a)); 

% Take log magnitude so we can see it better in the display.  

amplitudeImage=log(abs(frequencyImage));

amplitudeThreshold= 11;

brightSpikes=amplitudeImage>amplitudeThreshold; % either white or zero  

rowFilter=brightSpikes%row filter creation  

collumnFilter=brightSpikes%collumn filter creation  

rowFilter(150:200, :) = 0; %cut noice rows  

collumnFilter(:, 215:300) = 0;
%cut noice columns  

%imshowpair(rowFilter,collumnFilter, 'montage');  

frequencyImage(rowFilter)=0
%on rowFilter=1,frequencyImage=0  

frequencyImage(collumnFilter)=0
%on collumnFilter=1,frequencyImage=0  

%recreate the image using inverse 2FFT  

filteredImage=ifft2(fftshift(frequencyImage));

amplitudeImage3=abs(filteredImage);

minValue=min(min(amplitudeImage3));

maxValue=max(max(amplitudeImage3));

imshowpair(a,amplitudeImage3, 'montage');

%imshow(b)