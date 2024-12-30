function [] =leftdiagonalsharpening( img )
mask=[0 0 1;0  1 0;-1 0 0];
filter=imfilter(img,mask);
imshow(filter);
end
