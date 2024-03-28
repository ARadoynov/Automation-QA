function solve(wordToSearch, textForSearching) {
    'use strickt';

    const hasWord = textForSearching
        .toLowerCase()
        .split(' ')
        .includes(wordToSearch)

    if (hasWord) {
        console.log(wordToSearch)
    } else {
        console.log(`${wordToSearch} not found!`)
    }
}

solve('javascript', 'JavaScript is the best programming language')