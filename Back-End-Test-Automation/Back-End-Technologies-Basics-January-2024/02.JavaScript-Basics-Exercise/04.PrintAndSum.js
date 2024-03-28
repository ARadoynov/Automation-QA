function sumNumbers (n1, n2) {
    'use strict';
    let sum = 0;
    let numsArr = [];

    for (let i = n1; i <= n2; i++) {
        sum += i;
        numsArr.push(i);
        
    }
    console.log(numsArr.join(' '));
    console.log(`Sum: ${sum}`);
}

sumNumbers(5, 10);