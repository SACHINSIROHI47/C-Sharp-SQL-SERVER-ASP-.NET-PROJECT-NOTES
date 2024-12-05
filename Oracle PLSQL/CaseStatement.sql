SET SERVEROUTPUT ON;
DECLARE
vow char(1):='z';
BEGIN
  case vow
  when 'a' then dbms_output.put_line('Vowels is - '||vow);
  when 'e' then dbms_output.put_line('Vowels is - '||vow);
  when 'i' then dbms_output.put_line('Vowels is - '||vow);
  when 'o' then dbms_output.put_line('Vowels is - '||vow);
  when 'u' then dbms_output.put_line('Vowels is - '||vow);
  else dbms_output.put_line('Consonent is - '||vow);
  end case;
END;
