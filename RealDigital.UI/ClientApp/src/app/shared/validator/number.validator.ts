import { AbstractControl } from '@angular/forms';

export class NumberValidators {
  // Number only validation
  static numeric(control: AbstractControl) {
    let val = control.value;

    if (val === null || val === '') return null;

    if (!val.toString().match(/^[0-9]+(\.?[0-9]+)?$/)) return { 'numeric': true };

    return null;
  }

  //Phone number validation
  static phoneNo(control: AbstractControl) {
    let val = control.value;
    let isValid = false;

    if (val === null || val === '')
      return null;

    // Validate only phone numbers and not landline numbers
    if (val.toString().match(/^((?:\+27|27)|0)(\d{2})-?(\d{3})-?(\d{4})$/))
      isValid = true;
    else {
      if (val.toString().match(/^(?:(?:\(|)0|\+27|27)(?:1[12345678]|2[123478]|3[1234569]|4[\d]|5[134678])(?:\) | |-|)\d{3}(?: |-|)\d{4}$/))
        isValid = true;
    }

    if (!isValid)
      return { 'phonenumber': true };

    return null;
  }
}
