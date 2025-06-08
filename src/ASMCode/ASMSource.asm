.code
asmCalcuateRemainder PROC
    PUSH RBX
    XOR RAX, RAX        ; clear RAX register
    MOV Al, CL          ; save pixel value in AL
    MOV BH, DL          ; save divisor in BH
    DIV BH              ; divide pixel by divisor
    MOV BH, AH          ; save remainder of division in BH 

    mov AL, DL          ; save divisor in AL
    shr AL, 1           ; divide divisor by 2
    mov AH, AL          ; save divided by 2 divisor in AH

    CMP BH, AH          ; compare remainder with divided by 2 divisor
    JG FirstIF
    MOV AL, 0           ; save 0 in AL
    SUB AL, BH          ; substract pixel value from 0
    JMP Exit

    FirstIF:
        XOR RAX, RAX    ; clear RAX register
        MOV Al, CL      ; save pixel value in AL
        ADD Al, DL      ; add divisor to pixel value
        SUB Al, BH      ; substract remainder from AL

        CMP AX, CX      ; compare pixel+ divisor-(pixel%divisor) with pixel
        JG SecondIF
        MOV AL, 255     ; save 255 in AL
        SUB AL, CL      ; substract pixel from 255
        JMP Exit

   SecondIF:
        MOV AL, DL      ; save divisor in AL
        SUB AL, BH      ; substract pixel%divisor from divisor
    Exit:
    POP RBX
    RET                     
asmCalcuateRemainder ENDP


asmApplyFilter PROC 
	MOVDQU XMM1, [RCX]  ; save pixel array to XMM1
	MOVDQU XMM2, [RDX]  ; save rounding value to XMM2
	
	PADDB XMM1, XMM2    ; add rounding value to pixel array 

    MOVDQU [RCX], XMM1  ; replace pixel array with rounded values
    RET               						
asmApplyFilter ENDP
END