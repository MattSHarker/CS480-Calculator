Matthew Harker
CS480-Calculator

In order to use this calculator, you just need to be able to press the buttons on the gui.
The calculator does not take keyboard input, as the code currently does not check for anything besides numbers and the given operators

The number buttons will add the desired number to the current equation, or start a new one if a result is being shown.
The decimal button will do this as well, but if there is no leading number, it will automatically add a 0.
The negate button "+/-" will flip whether the current number is positive or negative. Ex: 3.5 will become -3.5, -4.2 will become 4.2

The different operator buttons "+", "-", "*", "/", "^", will produce the desired operator.
If the most recent entry to the equation is already an operator, it will be overwritten by the newest one.
This is to help prevent syntax errors, as well as making it easy to fix basics entry errors.

The parenthesis buttons "(", ")", will add the desired parenthesis to the equation.
Unlike the operators, these will not check for any previous parenthesis, and any amount can be added.

There are also three buttons for removing entries: Delete "<-", Clear "C", and Clear Everything "CE".
Delete will remove the most recent charachter added to the equation. Ex: "27 + 34" will become "27 + 3"
Clear removes the last operator or full number Ex: "27 + 34" will become "27 +"
Clear Everything removes everything. Ex: "27 + 34" will become ""
