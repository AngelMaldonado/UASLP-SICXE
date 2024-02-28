grammar SICXE;
 
/*
* Reglas del Parser
*/
 
programa:		
		inicio	(proposicion)+	fin // + -> match de cualquier subregla de 'proposicion' una o mas veces
	;
 
inicio: ID 'START' NUM FINL;
 
fin: 'END' (ID)? FINL;
 
proposicion: ID? (instruccion | directiva) FINL;

instruccion: (f1 | f2 | f3 | f4);
 
f1: OPF1;
f2: OPF2 (NUM | REG) | OPF2 REG ',' (REG | NUM);
f3: simple | indirecto | inmediato | OPF3;
f4: '+' f3;

simple: OPF3 (ID | NUM) | OPF3 (NUM | ID) ',' 'X';
indirecto: OPF3 '@' (NUM | ID);
inmediato: OPF3 '#' (NUM | ID);
 
directiva: ID TIPODIRECTIVA (NUM | OPDIRECTIVA);
 
/*
* Reglas del Lexico
*/
 
// Direcciones
OPF1			:	'FIX' | 'FLOAT' | 'HIO' | 'NORM' | 'SIO' | 'TIO';
OPF2			:	'ADDR' | 'CLEAR' | 'COMPR' | 'DIVR' | 'MULR' | 'RMO' | 'SHIFTL' | 'SHIFTR' | 'SUBR' | 'SVC' | 'TIXR';
OPF3			:	'ADD' | 'ADDF' | 'AND' | 'COMP' | 'COMPF' | 'DIV' | 'DIVF' | 'J' | 'JEQ' | 'JGT' | 'JLT' | 'JSUB' | 'LDA' | 'LDB' | 'LDCH' | 'LDF' | 'LDL' | 'LDS' | 'LDT' | 'LDX' | 'LPS' | 'MUL' | 'MULF' | 'OR' | 'RD' | 'RSUB' | 'SSK' | 'STA' | 'STB' | 'STCH' | 'STF' | 'STI' | 'STL' | 'STS' | 'STSW' | 'STT' | 'STX' | 'SUB' | 'SUBF' | 'TD' | 'TIX' | 'WD';
TIPODIRECTIVA	:	'BYTE' | 'WORD' | 'RESB' | 'RESW' | 'BASE';
OPDIRECTIVA		:	('C' | 'X') '\'' (ID | NUM) '\'';
REG				:	'A' | 'X' | 'L' | 'B' | 'S' | 'T' | 'F' | 'PC' | 'SW';
NUM				:	('0'..'9' | ('A'..'F') | ('a'..'f'))+ ('h' | 'H')?;
ID				:	('a'..'z' | 'A'..'Z')+;
FINL			:	'\n' | '\r\n';
WS				:	[ \t\r\n] -> channel(HIDDEN);//lineas o espacios en blanco ignorar 