import { rgbToHexColor } from '../src/rgb-to-hex.js';
import { expect } from 'chai';

describe ('', () => {
    it('should return undefined if red value is invalid', () => {
        const nonNumericRedValueResult = rgbToHexColor('255', 0, 0);
        const negativeRedValueResult = rgbToHexColor(-10, 0, 0);
        const outOfBoundRedValueResult = rgbToHexColor(999, 0, 0);
        const testWithNaNRedValue = rgbToHexColor(NaN, 0, 0)
        const testWithUndefinedValue = rgbToHexColor(undefined, 0, 0)

        expect(nonNumericRedValueResult).to.be.undefined
        expect(negativeRedValueResult).to.be.undefined
        expect(outOfBoundRedValueResult).to.be.undefined
        expect(testWithNaNRedValue).to.be.undefined
        expect(testWithUndefinedValue).to.be.undefined
    });

    it('should return undefined if green value is invalid', () => {
        const nonNumericGreenValueResult = rgbToHexColor(0, '255', 0);
        const negativeGreenValueResult = rgbToHexColor(0, -10, 0);
        const outOfBoundGreenValueResult = rgbToHexColor(0, 999, 0);
        const testWithNaNGreenValue = rgbToHexColor(0, NaN, 0)
        const testWithUndefinedValue = rgbToHexColor(0, undefined, 0)

        expect(nonNumericGreenValueResult).to.be.undefined
        expect(negativeGreenValueResult).to.be.undefined
        expect(outOfBoundGreenValueResult).to.be.undefined
        expect(testWithNaNGreenValue).to.be.undefined
        expect(testWithUndefinedValue).to.be.undefined
    });

    it('should return undefined if blue value is invalid', () => {
        const nonNumericBlueValueResult = rgbToHexColor(0, 0, '255');
        const negativeBlueValueResult = rgbToHexColor(0, 0, -10);
        const outOfBoundBlueValueResult = rgbToHexColor(0, 0, 999);
        const testWithNaNBlueValue = rgbToHexColor(0, 0, NaN)
        const testWithUndefinedValue = rgbToHexColor(0, 0, undefined)

        expect(nonNumericBlueValueResult).to.be.undefined
        expect(negativeBlueValueResult).to.be.undefined
        expect(outOfBoundBlueValueResult).to.be.undefined
        expect(testWithNaNBlueValue).to.be.undefined
        expect(testWithUndefinedValue).to.be.undefined
    });

    it('should return correct hex format if correct rgb value is given', () => {
        const redValue = 223;
        const greenValue = 123;
        const blueValue = 12;
    
        const result = rgbToHexColor(redValue, greenValue, blueValue);
        expect(result).to.equal('#DF7B0C');
    });

    it('should return correct hex format if correct max rgb value is given', () => {
        const redValue = 255;
        const greenValue = 255;
        const blueValue = 255;
    
        const result = rgbToHexColor(redValue, greenValue, blueValue);
        expect(result).to.equal('#FFFFFF');
    });

    it('should return correct hex format if correct min rgb value is given', () => {
        const redValue = 0;
        const greenValue = 0;
        const blueValue = 0;
    
        const result = rgbToHexColor(redValue, greenValue, blueValue);
        expect(result).to.equal('#000000');
    });
});