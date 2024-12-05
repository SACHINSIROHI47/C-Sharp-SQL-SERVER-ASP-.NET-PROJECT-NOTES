package onlineexam;

import java.sql.*;
import java.util.ArrayList;
import java.util.Collections;

public class DBManager {
    
    // <editor-fold desc="Declarations">
    private final static String DBDRIVER = "com.mysql.jdbc.Driver";
    private final static String DBURL = "jdbc:mysql://localhost:3306/exam";
    private final static String DBUSER = "root";
    private final static String DBPASSWORD = "root";
    private static Connection con;

    static
    {
        try
        {
            Class.forName(DBDRIVER);
            con = DriverManager.getConnection(DBURL,DBUSER,DBPASSWORD);
        }
        catch(Exception e){}
    } 
    // </editor-fold>
    
    // <editor-fold desc="User Functions">
    
    public static boolean authenticateUser(String userId, String password)
    {
        boolean flag=false;
        try
        {
            PreparedStatement ps = con.prepareStatement("Select * from users where UserId=? and Password=?");
            ps.setString(1,userId);
            ps.setString(2,password);
            ResultSet rs = ps.executeQuery();
            if(rs.next())
            {
                flag=true;
            }
            rs.close();
            ps.close();
        }
        catch(Exception e){}
        return flag;
    } 
    public static String getUserName(String userId)
    {
        String name="";
        try
        {
            PreparedStatement ps = con.prepareStatement("Select FirstName, LastName from users where UserId=?");
            ps.setString(1,userId);
            ResultSet rs = ps.executeQuery();
            rs.next();
            name = rs.getString(1)+" "+rs.getString(2);
            rs.close();
            ps.close();
        }
        catch(Exception e){}
        return name;
    }     
    public static int registerUser(String userId, String password, String firstName, String lastName)
    {
        int x = 0;
        try
        {
            PreparedStatement ps1 = con.prepareStatement("Select * from users where UserId=?");
            ps1.setString(1,userId);
            ResultSet rs = ps1.executeQuery();
            if(rs.next())
            {
                x = 1;
            }
            else
            {
                PreparedStatement ps2 = con.prepareStatement("Insert into Users(UserId,Password, FirstName,LastName) values(?,?,?,?)");
                ps2.setString(1,userId);
                ps2.setString(2,password);
                ps2.setString(3,firstName);
                ps2.setString(4,lastName);
                ps2.executeUpdate();
                ps2.close();
                x = 2;
            }
            rs.close();
            ps1.close();
        }
        catch(Exception e){e.printStackTrace();}
        return x;
    }  
    
    // </editor-fold>
    
    // <editor-fold desc="Subject Related Functions">
    public static String[] getSubjects(){
        ArrayList<String> list = new ArrayList<String>();
         try
        {
            PreparedStatement ps = con.prepareStatement("Select * from Subjects");
            ResultSet rs = ps.executeQuery();
            while(rs.next())
            {
                list.add(rs.getString(1));
            }
            rs.close();
            ps.close();
        }
        catch(Exception e){}  
        Collections.sort(list);
        String[] subjects = new String[list.size()];
        for(int i=0;i<list.size();i++){
            subjects[i] = list.get(i);
        }            
        return subjects;
    }
    // </editor-fold>
    
    // <editor-fold desc="Report Related Functions">
    public static void saveReport(ExamReport r){
        try
        {
            PreparedStatement ps = con.prepareStatement("Insert into reports(UserId,UserName,ExamDate,Subject,Level,TotalQuestions,CorrectQuestions,Score) values (?,?,?,?,?,?,?,?)");
            ps.setString(1,System.getProperty("userId"));
            ps.setString(2,r.getStudentName());
            ps.setString(3,r.getExamDate());
            ps.setString(4,r.getSubject());
            ps.setString(5,r.getLevel());
            ps.setString(6,""+r.getNumberOfQuestions());
            ps.setString(7,""+r.getCorrect());
            ps.setString(8,r.getScore()+"%");
            ps.executeUpdate();
            ps.close();
        }
        catch(Exception e){}  
    }
    // </editor-fold>
    
    // <editor-fold desc="Questions Related Functions">
    public static ArrayList<Question> getQuestions(String subject, String level){
        ArrayList<Question> list = new ArrayList<Question>();
         try
        {
            PreparedStatement ps = con.prepareStatement("Select * from Questions where Subject=? and DifficultyLevel=?");
            ps.setString(1, subject);
            ps.setString(2, level);
            ResultSet rs = ps.executeQuery();
            while(rs.next())
            {
                Question q = new Question();
                q.setQuestionId(rs.getInt(1));
                q.setQuestionText(rs.getString(2));
                q.setOptionA(rs.getString(3));
                q.setOptionB(rs.getString(4));
                q.setOptionC(rs.getString(5));
                q.setOptionD(rs.getString(6));
                q.setCorrectAnswer(rs.getString(7));
                q.setSubject(rs.getString(8));
                q.setDifficultyLevel(rs.getString(9));
                list.add(q);
            }
            rs.close();
            ps.close();
        }
        catch(Exception e){}       
        return list;
    }    
     // </editor-fold>
}
