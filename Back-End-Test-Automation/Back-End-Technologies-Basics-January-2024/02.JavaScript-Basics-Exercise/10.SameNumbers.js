function sameNumbers(number) {
    let numsArr = Array.from(String(number), Number);
    let sum = 0;
    let isEqual = true;

    numsArr.forEach(element => {
        sum += element;
        let nextEl = numsArr[element + 1];

        if (element != nextEl) {
            isEqual = false;
        }
    });

    if (isEqual) {
        console.log('true');
    } else {
        console.log('false');
    }

    console.log(sum);

}

sameNumbers(1234);