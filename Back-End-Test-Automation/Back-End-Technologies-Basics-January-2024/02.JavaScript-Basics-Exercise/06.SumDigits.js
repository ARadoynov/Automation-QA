function sumDigits (number) {

    let arrayOfDigits = Array.from(String(number), Number);
    let sum = 0;
    for (let i = 0; i < arrayOfDigits.length; i++) {
        let currentNum = arrayOfDigits[i];
        sum += currentNum;
    }
    
    console.log(sum)
}

sumDigits(97561);