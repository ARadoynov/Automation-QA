import {isOddOrEven} from "../src/isOddOrEven.js"
import { expect } from "chai"

describe ('isOddOrEven', () => {

    it('should return undefined if value different than string is given', () => {
        expect(isOddOrEven(1)).to.be.undefined
        expect(isOddOrEven(undefined)).to.be.undefined
        expect(isOddOrEven(NaN)).to.be.undefined
    });

    it('should return even value when given string with even count of chars', () => {
        expect(isOddOrEven('AB')).to.equals('even')
    });

    it('should return odd value when given string with odd count of chars', () => {
        expect(isOddOrEven('A')).to.equals('odd')
    });

    it('should return even or odd whhen given multiple strings', () => {
        expect(isOddOrEven('AB ABC')).to.equals('even')
        expect(isOddOrEven('ABC ABC')).to.equals('odd')
    });
});