function solve(n1, n2, n3) {
    'use strict';

    function addition(n1, n2) {
        return n1 + n2;
    }

    function substract(resultOfAddition, n3) {
        return resultOfAddition - n3;
    }

    const resultOfAddition = addition(n1, n2);
    const finalResult = substract(resultOfAddition, n3);

    console.log(finalResult);
}

solve(23, 6, 10);
