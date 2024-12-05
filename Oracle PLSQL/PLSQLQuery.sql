--SET SERVEROUTPUT ON;
--DECLARE
--NUM1 INTEGER:=50;
--NUM2 INTEGER:=60;
--TOTAL INTEGER:=0;
--BEGIN
--total:=num1+num2;
--dbms_output.put_line('total number is '||total);
--END;

--------constant we can not change the values of variable once assing------ 
--DECLARE
--marks constant number:=90.25;
--gender CHAR(2):='M';
--sname VARCHAR(100):='James Smith';
--dob DATE:='06-05-1991';
--begin
--DBMS_OUTPUT.PUT_LINE('StdMarks is '||marks);
--DBMS_OUTPUT.PUT_LINE('Gnder is '||gender);
--DBMS_OUTPUT.PUT_LINE('Name is '||sname);
--DBMS_OUTPUT.PUT_LINE('Date of Birth is '||dob);
--END;

------------Condition using IF-Else------
DECLARE
mrk INTEGER:=70;
begin
    if mrk>=60 
    then
             DBMS_OUTPUT.PUT_LINE('PASS');
    else
             DBMS_OUTPUT.PUT_LINE('FAIL');
    END if;
               DBMS_OUTPUT.PUT_LINE('Ending');
END;



