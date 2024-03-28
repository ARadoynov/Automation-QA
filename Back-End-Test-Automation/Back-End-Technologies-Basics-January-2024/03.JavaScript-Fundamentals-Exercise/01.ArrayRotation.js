function shiftElements (numsArr, rotations) {
    'use strict';

    for (let i = 1; i <= rotations; i++) {
        let removedNum = numsArr.shift();
        numsArr.push(removedNum);
    }
    console.log(numsArr.join(' '));
}

shiftElements([32, 21, 61, 1], 4);
