function sortNumbers(arr) {
    'use strict';

    arr.sort((a, b) => a - b);

    const result = [];
  
    while (arr.length > 0) {
      result.push(arr.shift());
  
      if (arr.length > 0) {
        result.push(arr.pop());
      }
    }
    
    for (let i = 0; i < result.length; i++) {
      console.log(result[i]);
    }
    
  }
  
  sortNumbers([1, 65, 3, 52, 48, 63, 31, -3, 18, 56]);

