function solve(input) {

    function checkLength(input) {
        let isValidLength = true;
        if (input.length < 6 || input.length > 10) {
            isValidLength = false;
        }

        return isValidLength;
    }

    function checkContent(input) {
        var regex = /[^a-zA-Z0-9]/;
        let isValidContent = true;

        if (regex.test(input)) {
            isValidContent = false;
        }

        return isValidContent;
    }

    function checkDigitsCount(input) {
        var digitCount = 0;
        let isValidCount = true;

        for (var i = 0; i < input.length; i++) {
            var charCode = input.charCodeAt(i);

            if (charCode >= 48 && charCode <= 57) {
                digitCount++;
            }
        }

        if (digitCount < 2) {
            isValidCount = false;
        }

        return isValidCount;
    }

    function printValidMessage() {
        console.log('Password is valid');
    }

    function printLengthMessage() {
        console.log('Password must be between 6 and 10 characters');
    }

    function printContentMessage() {
        console.log('Password must consist only of letters and digits');
    }

    function printDigitsCountMessage() {
        console.log('Password must have at least 2 digits');
    }

    var isValidLength = checkLength(input);
    var isValidContent = checkContent(input);
    var isValidCountDigits = checkDigitsCount(input);
    
    if (isValidLength && isValidContent && isValidCountDigits) {
        printValidMessage();
    } 

    if (!isValidLength) {
        printLengthMessage();
    }

    if (!isValidContent) {
        printContentMessage();
    }

    if (!isValidCountDigits) {
        printDigitsCountMessage();
    }
    
}

solve('Pa$s$s');