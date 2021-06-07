function DoubleDestroyer(){
    let inputString = "у попа?была   собака";
    let tempArray;
    let arrayToDelete;
    let inputArray = inputString.split(' ').join(',').split('?').join(',').split('!').join(',').split(':').join(',').split(';').join(',').split('.').join(',').split(',');
    console.log(inputArray);
    for (let i = 0; i <= inputArray.length; i++){
        if (inputArray[i] == ""){
            inputArray.splice(i, 1);
            i--;
        }
    }
    console.log(inputArray);
    for (let m = 0; m < inputArray.length; m++) {
        tempArray = inputArray[m].split("");
        console.log(tempArray);
        for (let j = 0; j < tempArray.length; j++) {
            for (let k = j + 1; k <= tempArray.length; k++) {
                if (tempArray[j] == tempArray[k]) {
                    arrayToDelete.push(tempArray[j]);
                }
            }
        }
    }
    console.log(arrayToDelete);
}