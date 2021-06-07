function DoubleDestroyer(){
    let inputString = "от; топота . копыт пыль ,   по !!полю ???летит";
    let tempArray = [];
    let arrayToDelete = [];
    let inputArray = inputString.split(' ').join(',').split('?').join(',').split('!').join(',').split(':').join(',').split(';').join(',').split('.').join(',').split(',');
    for (let i = 0; i <= inputArray.length; i++){
        if (inputArray[i] == ""){
            inputArray.splice(i, 1);
            i--;
        }
    }
    for (let m = 0; m < inputArray.length; m++) {
        tempArray = inputArray[m].split("");
        for (let j = 0; j < tempArray.length; j++) {
            for (let k = j + 1; k <= tempArray.length; k++) {
                if (tempArray[j] == tempArray[k]) {
                    arrayToDelete.push(tempArray[j]);
                }
            }
        }
    }
    for (let p = 0; p < inputArray.length; p++) {
        tempArray = inputArray[p].split("");
        for (let n = 0; n < tempArray.length; n++) {
            for (let o = 0; o < arrayToDelete.length; o++) {
                if (tempArray[n] == arrayToDelete[o]) {
                    tempArray.splice(n, 1);
                }
            }
        }
        inputArray[p] = tempArray.join("");
    }
    console.log(inputArray.join(" "));
}