import { expect } from "chai";
import { lookupChar } from "../src/charLookup.js"

describe ('charLookup', () => {
    it ('should return undefined when given first parameter is not a string', () => {
        expect(lookupChar(10, 5)).to.be.undefined
    });

    it ('should return undefined when given first parameter is not a number', () => {
        expect(lookupChar('string', 'string')).to.be.undefined
        
    });

    it ('should return undefined when second parameter is floating point number', () => {
        expect(lookupChar('string', 10.10)).to.be.undefined
        
    });

    it ('should return incorrect index when given incorrect second param value', () => {
        expect(lookupChar('string', 6)).to.equals('Incorrect index')
        expect(lookupChar('string', 7)).to.equals('Incorrect index')
        expect(lookupChar('string', -1)).to.equals('Incorrect index')
        expect(lookupChar('', 0)).to.equals('Incorrect index')
    });

    it ('should return character at specified index in string when given correct parameters', () => {
        expect(lookupChar('string', 1)).to.equals('t')
        expect(lookupChar(' ', 0)).to.equals(' ')
    });
});