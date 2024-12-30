function [] = leftdiagonaledgedetection( img )
mask=[2 1 0;1 0 -1 ;0 -1 -2];
x=imfilter(img,mask);
left=edge(x,'log');
imshow(left);
end
