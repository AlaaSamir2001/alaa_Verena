function [] =rightdiagonalsharpening( img )
mask=[1 0 0;1 1 -1;0 0 0];
filter=imfilter(img,mask);
imshow(filter);
end