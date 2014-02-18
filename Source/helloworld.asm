section .data
  msg   db    'Hello world!', 0AH
  len   equ   $-msg

section .text
  global _main

_main
  mov   edx, len
  mov   ecx, msg
  mov 	al , msg
  mov   ebx, 1
  mov   eax, 4
  ;int   80h

  mov   ebx, 0
  mov   eax, 1
  ;int   80h
  ret