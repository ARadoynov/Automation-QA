function multiply (number) {
    'use strict';

    for (let times = 1; times <= 10; times++ ) {
        let result = number * times;
        console.log(`${number} X ${times} = ${result}`)
    }
}

multiply(5);