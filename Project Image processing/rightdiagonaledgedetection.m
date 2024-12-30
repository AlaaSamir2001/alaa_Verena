function [] = rightdiagonaledgedetection( img )
mask=[0 -1 -2;1 0 -1; 2 1 0];
x=imfilter(img,mask);
right=edge(x,'log');
imshow(right);
end
