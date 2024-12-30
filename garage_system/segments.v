

module decodeSEG(A,B,C,D,led_a,led_b,led_c,led_d,led_e,led_f,led_g);
  input A,B,C,D;
  output led_a,led_b,led_c,led_d,led_e,led_f,led_g ;
assign leds_a= ~(A | C | B&D | ~B&~D);
assign leds_b = ~(~B | ~C&~D | C&D);
assign leds_c = ~(B | ~C | D);
assign leds_d = ~(~B&~D | C&~D | B&~C&D | ~B&C |A);
assign leds_e= ~(~B&~D | C&~D);
assign leds_f = ~(A | ~C&~D | B&~C | B&~D);
assign leds_g= ~(A | B&~C | ~B&C | C&~D);

endmodule


///////////////////////////////

module counter_to_decoder(clk,reset, count, leds,leds2);
input clk , reset ; 
output wire [6:0] leds ,  leds2; 
input [5:0] count;
wire clk1Hz; 
//clock_divider div (clk, reset, clk1Hz);
segcount bcd_cnt ( count ); 
 wire [3:0] digit1 = count%10;
 wire [3:0] digit2 = count /10;

decodeSEG seg (digit1[3],digit1[2],digit1[1],digit1[0],leds[6],leds[5],leds[4],leds[3],leds[2],leds[1],leds[0]);
decodeSEG seg2 (digit2[3],digit2[2],digit2[1],digit2[0],leds2[6],leds2[5],leds2[4],leds2[3],leds2[2],leds2[1],leds2[0]);

endmodule





