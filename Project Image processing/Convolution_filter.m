function result = Convolution_filter(im, filter)
    % Rotate the image 180 degrees
    im = imrotate(im, 180);

    % Call the Correlation_filter function
    result = Correlation_filter(im, filter);
end

function result = Correlation_filter(im, filter)
    M = length(filter);
    k = (M-1) / 2;
    im = double(padarray(im, [k, k]));

    [H, W] = size(im);
    result = zeros(H, W);

    for i = 1+k:H-k
        for j = 1+k:W-k
            subimg = im(i-k:i+k, j-k:j+k);
            result(i, j) = sum(sum(subimg .* filter));

            if result(i, j) > 255
                result(i, j) = 255;
            elseif result(i, j) < 0
                result(i, j) = 0;
            end
        end
    end

    result = uint8(result);
    result = result(1+k:H-k, 1+k:W-k);
end
