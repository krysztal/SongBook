import { Component, ViewEncapsulation, OnInit } from "@angular/core";
import { FormGroup, FormBuilder, Validators } from "@angular/forms";
import { emailValidator } from "./email.validator";

@Component({
    moduleId: module.id,
    selector: "login",
    templateUrl: "login.component.html",
    styleUrls: ["login.component.css"],
    encapsulation: ViewEncapsulation.None
})
export class LoginComponent implements OnInit {
    userForm: FormGroup;
    user: LoginData = new LoginData();
    formErrors = {
        "email": "",
        "password": ""
    };

    validationMessages = {
        "email": {
            "required": "Pole jest wymagane.",
            "emailValidator": "Nie prawidłowy format."
        },
        "password": {
            "required": "Pole jest wymagane.",
            "minlength": "Minimalna liczba znaków 6."
        }
    };

    constructor(private fb: FormBuilder) { }

    ngOnInit() {
        this.buildForm();
    }

    buildForm() {
        this.userForm = this.fb.group({
            "email": [this.user.email, [
                Validators.required,
                emailValidator
            ]],
            "password": [this.user.password, [
                Validators.required,
                Validators.minLength(6)
            ]]
        });
        
        this.userForm.valueChanges
            .subscribe(data => this.onValueChange(data));
    }

    onValueChange(data?: any) {
        if(!this.userForm) return;
        let form = this.userForm;

        for (let field in this.formErrors) {
            this.formErrors[field] = "";
            let control = form.get(field);

            if (control && control.dirty && !control.valid) {
                let message = this.validationMessages[field];
                for (let key in control.errors) {
                    this.formErrors[field] += message[key] + " ";
                }
            }
        }
    }

}



class LoginData {
    public email: string;
    public password: string;
}