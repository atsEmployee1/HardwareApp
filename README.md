; AD1520 System Initialization and Handshake Sequence
; Ensures system is homed, ready, and safe to proceed

; Step 1: Initialize system (optional, depending on version)
INIT

; Step 2: Home all axes
HOME X
WAIT 100
HOME Y
WAIT 100
HOME Z
WAIT 100

; Step 3: Check sensor states (if available)
; You may skip this if your system doesn’t have interlocks
; For example:
; IF SENSOR DOOR_OPEN == TRUE
;     ABORT "Door is open"
; ENDIF

; Step 4: Reset pumps or clear volumes (optional)
; CALL RESET_PUMPS

; Step 5: Move to a safe Z height
GOTO Z=5000
WAIT 100

; Step 6: System is ready
; Continue with job, or return control to calling block
RETURN
