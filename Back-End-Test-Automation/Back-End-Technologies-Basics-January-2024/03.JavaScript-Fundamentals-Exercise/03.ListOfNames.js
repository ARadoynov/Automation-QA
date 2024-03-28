function sortNames(inputArr) {
    'use strict';

    inputArr.sort((a, b) => a.localeCompare(b));

    for (let i = 1; i <= inputArr.length; i++) {
        console.log(`${i}.${inputArr[i - 1]}`)
    }
}

sortNames(['Atanas', 'Venelina']);