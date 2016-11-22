
import java.io.*;
import java.net.*;

public class Register {
	public static void main(String[] args) {
		try{
			String hostName = "10.0.0.2";
			int port = 12000;		
			String data_S="mac|zxcasd|mac grint|F|Fort Wayne 46805|260-455-1345|Favorite Food?|pasta";
			
			Socket s = new Socket(hostName, port);
			System.out.println("Operration: ");
			
			BufferedReader br = new BufferedReader(new InputStreamReader(System.in));
			String sentence = br.readLine();
			    
			
			PrintWriter out = new PrintWriter(s.getOutputStream(), true);			
			out.println(sentence);
			System.out.println("Sentence is sent to server.");			
			
			//System.out.println("Entered Details: ");
			//br = new BufferedReader(new InputStreamReader(System.in));
			System.out.println("Entered Details:  " + data_S);
			sentence = data_S;
			out = new PrintWriter(s.getOutputStream(), true);			
			out.println(sentence);


			
			BufferedReader in = new BufferedReader(new InputStreamReader(s.getInputStream()));
			System.out.println(in.readLine());
			
			
			
	//		in = new BufferedReader(new InputStreamReader(s.getInputStream()));
		//	System.out.println(in.readLine());
			
			br.close();
			in.close();
			out.close();
			s.close();
		}
		catch(Exception e) {
			System.err.println(e.getMessage());
			System.err.println("Usage: java Client");
		}		
	}
}
