function QuickMath(inputString) {
    let calcArray = [];

    const operators = ['+', '-', '*', '/', '='];

    let operatorsPosing = [];

    calcArray =  inputString.replace('=','').split(/[\+\-\*\/\=]/).map(Number);

    inputString.split('').forEach(element => 
        {
        if(operators.indexOf(element) !=-1)
        {
            operatorsPosing.push(element);
        }
    });

    let result = calcArray[0];

    operatorsPosing.forEach((op, i)=>
    {
        if(op === "+")
        {
            result+=calcArray[i+1];
        }
        else if(op === "-")
        {
            result-= calcArray[i+1];
        }
        else if(op === "*")
        {
            result*=calcArray[i+1];
        }
        else if(op === "/")
        {
            result/=calcArray[i+1];
        }
    })

    return result.toFixed(2);
}