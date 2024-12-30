function [ ] = bluringmeanfilter( img )
noisedimg=imnoise(img,'salt & pepper');
%h=1;
%h=1/25;
h = fspecial('average',5);
averagefilter=imfilter(noisedimg,h);
figure,imshow(averagefilter);
end

