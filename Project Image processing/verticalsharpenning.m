function [] =verticalsharpenning( img )
mask=[1 0 1;0 1 0;0 -1 0];
filter=imfilter(img,mask);
imshow(filter);
end

