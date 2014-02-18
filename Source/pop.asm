
;	compile with nasm -f win32 pop.asm
;	link with link pop.obj /OUT:pop.exe /SUBSYSTEM:CONSOLE /ENTRY:start

;	Declare the required labels


global _start
global _end
global _loop
global _or
global _xor
global _and
global _not

section .data
;	This is the .data section in the .data section we declare all of our variables

times 3619 - ($-$$) db 0 ;	This line adds 3619 0s after the code to increase the size to 4096 bytes (Windows Default Allocation Size)

section .text
;	This is the .text section in the .text section is where the actual code to be ran is written

_start: ;	This is the main entry point for the program

mov ebx, 100000000000 ;	move a value of 100000000000 to the ebx register this will be the number of loop iterations
mov ecx, 0 ;	move a value of 0 to the ecx register this will be a loop counter
push ebx ;		push the value of ebx register onto the stack (Stack = RAM) 
push ecx ;		push the value of ecx register onto the stack (Stack = RAM) 
cmp ebx, ecx ;	Compare the value of ebx with the value of ecx
jg _loop ;		if ebx is greater than ecx jump to the _loop label
jmp _end ;		else jump to _end
ret 	 ;		return

_loop:	 ; 		This is the _loop label this label contains the code to be repeated

inc ecx  ;		Increment the eax register (the loop counter)
cmp ebx,ecx ;	Compare the value of ebx with the value of ecx
jg _loop ; 		if ebx is greater than ecx jump to the _loop label
je _or   ;		else jump to _end
ret		;		return

_end: 	; this is the _end label this label contains the code ends the 
		; To end a program you must pop all the data that is pushed on the stack 'by push instructions' off the stack 
pop ebx ; Pop ebx off the stack and back into the ebx register
pop ecx ; Pop ecx off the stack and back into the ecx register
ret 	; return

_or:

mov esi,1 ; move 1 to the esi register
mov edi,0 ; move 0 to the edi register
or edi,esi; perform a bitwose or operation on the values of edi, esi registers 
cmp edi,0 ; compare the value of esi to 0
je _end ; if esi and 0 are equal jump to end
jmp _xor ; else jump to xor
ret		; return

_xor:

mov esi,1 ; move 1 to the esi register
mov edi,0 ; move 0 to the edi register
xor edi,esi; perform a bitwose xor operation on the values of edi, esi registers 
cmp edi,1 ; compare the value of esi to 0
je _end ; if esi and 0 are equal jump to end
jmp _and ; else jump to and
ret		; return

_and:

mov esi,1 ; move 1 to the esi register
mov edi,0 ; move 0 to the edi register
and edi,esi; perform a bitwose and operation on the values of edi, esi registers 
cmp edi,1 ; compare the value of esi to 0
je _end ; if esi and 0 are equal jump to end
jmp _not ; else jump to not
ret		; return

_not:

mov edi,0 ; move 0 to the edi register
not edi; perform a bitwise and operation on the values of edi registers
cmp edi,1 ; compare the value of esi to 0
je _end ; if esi and 0 are equal jump to end
ret		; return
