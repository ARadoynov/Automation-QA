function solve(input) {


    function sumOdd(input) {
        let inputArr = Array.from(String(input), Number);
        let oddSum = 0;

        inputArr.forEach(element => {
            if (element % 2 != 0) {
                oddSum += element;
            }
        });

        return oddSum;
    }

    function sumEven(input) {
        let inputArr = Array.from(String(input), Number);
        let evenSum = 0;

        inputArr.forEach(element => {
            if (element % 2 == 0) {
                evenSum += element;
            }
        });

        return evenSum;
    }

    const oddSum = sumOdd(input);
    const evenSum = sumEven(input);

    console.log(`Odd sum = ${oddSum}, Even sum = ${evenSum}`)
}

solve(1000435);