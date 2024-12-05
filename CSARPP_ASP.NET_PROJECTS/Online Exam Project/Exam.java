package onlineexam;

import java.util.ArrayList;
import java.util.Collections;

public class Exam {
    ArrayList<Question> list;
    int numberOfQuestions;

    public ArrayList<Question> getList() {
        return list;
    }

    public int getNumberOfQuestions() {
        return numberOfQuestions;
    }
    
    public Question getQuestion(int index){
        return list.get(index);
    }
    
    public Exam(String subject, String level, int numberOfQuestions){
        this.numberOfQuestions = numberOfQuestions;
        list = DBManager.getQuestions(subject, level);
        Collections.shuffle(list);
        while(list.size()>numberOfQuestions){
            list.remove(numberOfQuestions);
        }
    }
    public int getAttemptedQuestions() {
        int x = 0;
        for(Question q : list){
            if(!q.getUserAnswer().equals(""))
                x++;
        }
        return x;
    }    
    public int getCorrectQuestions() {
        int x = 0;
        for(Question q : list){
            if(q.getUserAnswer().equals(q.getCorrectAnswer()))
                x++;
        }
        return x;
    }    
}
