global main

org 100h

main:
mov ah,9
mov dx,hello_message
int 21h
ret

hello_message db 'Hello World! $'
