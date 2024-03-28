function returnElement(inputArr, n) {
    'use strict';

    const result = [];
    for (let i = 0; i < inputArr.length; i += n) {
        result.push(inputArr[i])
    }

    return result
}

console.log(returnElement(['5', '20', '31', '4', '20'], 2)); 