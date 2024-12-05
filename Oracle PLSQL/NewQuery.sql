set SERVEROUTPUT ON;
Declare
a int:=50;
b int:=60;
c int;
Begin
c:=a+b;
dbms_output.put_line('Addition of Two Number '||c);
    Declare
        rollno integer:=101;
        sname char(50):='James';
    BEGIN
        DBMS_OUTPUT.PUT_LINE('Student Rollno is '||rollno);
        DBMS_OUTPUT.put_line('Student Name is '||sname);
    END;
End;