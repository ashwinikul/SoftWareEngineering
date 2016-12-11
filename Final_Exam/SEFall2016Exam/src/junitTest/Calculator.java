package junitTest;

// For calculator its better to have float stack, as divide may lead to float result

public class Calculator extends RuntimeException {
	public Calculator() {}
	
	public static int CalculatorFromReversePolish(String expression) {
		int result = 0;
		Stack<Integer> stack = new Stack<Integer>();
		String tokens[] = expression.split(" ");	
		int x,y;
		if (tokens.length == 0)
			throw new RuntimeException();
		
		for (int i = 0; i < tokens.length; i++) {
			if (tokens[i].equals("+")) {
				
				stack.push((Integer)stack.pop() + (Integer)stack.pop());
			}
			else if (tokens[i].equals("*")) {
				stack.push((Integer)stack.pop() * (Integer)stack.pop());
			}
			else if (tokens[i].equals("-")) {
				x=(Integer)stack.pop(); // Fixes
				y=(Integer)stack.pop(); // Fixes
				stack.push( y - x); //Fixes
			}
			else if (tokens[i].equals("/")) {
				x=(Integer)stack.pop(); // Fixes
				y=(Integer)stack.pop(); // Fixes
				stack.push(y/x); // Fixes
			}
			else {
				try {
					Integer op = Integer.parseInt(tokens[i]);
					stack.push(op);
				}
				catch (NumberFormatException e) {}
			}
		}		
		
		if (stack.isEmpty())
			throw new RuntimeException();
		
		result = stack.pop();
		
		if (!stack.isEmpty())
			throw new RuntimeException();
		
		return result;
	}
}
