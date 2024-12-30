function [] =horizontalsharpenning( img )
mask=[0 0 0;1  1 -1 ;0 0 0];
filter=imfilter(img,mask);
%sharp=imsubtract(img,filter); %make the image black 
imshow(filter);
end


