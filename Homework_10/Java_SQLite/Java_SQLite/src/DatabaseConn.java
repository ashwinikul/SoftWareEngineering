import java.sql.*;

public class DatabaseConn {
	static Connection c = null;
    static Statement stmt = null;
    
	public static void query_exec(String S)
	{
		try{
		stmt = c.createStatement();
		stmt.executeUpdate(S);
		}
		catch ( Exception e ) {
		      System.err.println( e.getClass().getName() + ": " + e.getMessage() );
		      System.exit(0);
		}
		
	}

	public static void main(String[] args) {

	    try {
	      Class.forName("org.sqlite.JDBC");
	      c = DriverManager.getConnection("jdbc:sqlite:P2.db");
	      System.out.println("Opened database successfully");

	      query_exec("drop table if exists CourseDetails;"); 
	      
	      query_exec("CREATE TABLE CourseDetails (ID int primary key not null, Semester VARCHAR(15), Course VARCHAR(50))"); 
	      
	      query_exec("insert into CourseDetails values(1,'Fall 2016','Software Engineering');"); 

	      query_exec("insert into CourseDetails values(2,'Spring 2016','Software Project Management');"); 

	      ResultSet rs =stmt.executeQuery("select * from CourseDetails;");
	      System.out.println( "Semester \t Course");
	      System.out.println( "_____________ \t ______________________");
	      while ( rs.next() ) {
	          int id = rs.getInt("id");
	          String  semester = rs.getString("semester");
	          String  course = rs.getString("course");
 	          System.out.println( semester + "\t"+ course);
	          System.out.println();
	       }
	       rs.close();
 

	      stmt.close();
	      c.close();
	    } catch ( Exception e ) {
	      System.err.println( e.getClass().getName() + ": " + e.getMessage() );
	      System.exit(0);
	    }
	    System.out.println("Table created successfully");
	  }


	}


