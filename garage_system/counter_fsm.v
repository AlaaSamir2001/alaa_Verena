module counter_fsm(  
  input clk,
  input reset,
  input car_in,
  input car_out,
  output reg [5:0] count,
  output reg [1:0] state
);

parameter S0 = 2'b00,
	  S1 = 2'b01,
	  S2 = 2'b10,
	  S3 = 2'b11;

always @(posedge clk or posedge reset) begin
  
    if(reset) begin
    state <= S0;
    count <= 0;
    $display(count);
  end else begin  
  
  case(state)
    S0: begin
      if(car_in) begin
        state <= S1;
        count <= 1;
	$display(count);
      end else begin
        state <= S0;
        count <= 0;
	$display(count);
      end
    end
    S1: begin
      if(car_in && count < 50) begin
        state <= S1;
        count <= count + 1;
	$display(count);
      end else if (car_in && count >=50) begin
         state <= S3;
         count <= 50;
        $display("Garage is full");
      end else if (car_out && count > 0) begin
        state <= S2;
        count <= count - 1;
	$display(count);
      end else if (car_out && count <=0 ) begin
        state <= S0;
        count <= 0;
	$display(count);
      end
    end
    S2: begin
      if(car_out && count > 1) begin
        state <= S2;
        count <= count - 1;
	$display(count);
      end else if (car_out && count <=0) begin
        state <= S0;
        count <= 0;
	$display(count);
      end else if (car_in && count < 50) begin
        state <= S1;
        count <= count + 1;
	$display(count);
      end else if (car_in && count >= 50) begin
        state <= S3;
        $display("Garage is full");
      end
    end
    S3: begin
      if(car_in) begin
        state <= S3;
        $display("Garage is full");
      end else if (car_out ) begin
        state <= S2;
        count <= count - 1;
	$display(count);
      end 
    end
  endcase
  end
end
endmodule


module testingBench();
  reg clk , reset;
  wire car_in,car_out;
  wire [5:0] count;
  wire [1:0] state;
  
  initial 
  begin 
    clk =0;
    reset =1; #100
    reset = 0;
    
end
always
#100 clk =~clk;
counter_fsm FSM(clk , reset, car_in,car_out,count,state);

initial begin
$display("\t\t Time clk reset car_in car_out count state");
$monitor("%d,%b,%b,%b,%b,%b,%b" ,$time,clk,reset,car_in,car_out,count,state); 
  

end
endmodule


module segcount(input wire [5:0] count );
endmodule