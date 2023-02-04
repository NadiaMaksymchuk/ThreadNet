import { Component, OnInit, Inject, OnDestroy } from '@angular/core';
import { MatDialogRef, MAT_DIALOG_DATA } from '@angular/material/dialog';
import { DialogType } from '../../models/common/auth-dialog-type';
import { Subject } from 'rxjs';
import { AuthenticationService } from '../../services/auth.service';
import { takeUntil } from 'rxjs/operators';
import { SnackBarService } from '../../services/snack-bar.service';
import { FormGroup, FormControl, Validators, FormBuilder, AbstractControl } from '@angular/forms';

@Component({
    templateUrl: './auth-dialog.component.html',
    styleUrls: ['./auth-dialog.component.sass']
})
export class AuthDialogComponent implements OnInit, OnDestroy {
    public dialogType = DialogType;
    public userName: string = '';
    public password: string = '';
    public avatar: string;
    public email: string = '';

    public hidePass = true;
    public title: string;
    private unsubscribe$ = new Subject<void>();

    form: FormGroup = new FormGroup({
      userName: new FormControl(this.userName),
      email: new FormControl(this.email),
      password: new FormControl(this.password)
    });
    submitted = false;

    constructor(
        private dialogRef: MatDialogRef<AuthDialogComponent>,
        @Inject(MAT_DIALOG_DATA) public data: any,
        private authService: AuthenticationService,
        private snackBarService: SnackBarService,
        private formBuilder: FormBuilder
    ) {}

    public ngOnInit() {
        this.avatar = 'https://avatars.mds.yandex.net/get-ott/374297/2a000001616b87458162c9216ccd5144e94d/orig';
        this.title = this.data.dialogType === DialogType.SignIn ? 'Sign In' : 'Sign Up';
    }

    public ngOnDestroy() {
        this.unsubscribe$.next();
        this.unsubscribe$.complete();
    }

    get f(): { [key: string]: AbstractControl } {
      return this.form.controls;
    }
  
    public close() {
        this.dialogRef.close(false);
    }

    public signIn() {
      this.validateData();
      this.onSubmit();
        this.authService
            .login({ email: this.email, password: this.password })
            .pipe(takeUntil(this.unsubscribe$))
            .subscribe((response) => this.dialogRef.close(response), (error) => this.snackBarService.showErrorMessage(error));
    }

    public signUp() {
      this.validateData();
      this.onSubmit();
        this.authService
            .register({ userName: this.userName, password: this.password, email: this.email, avatar: this.avatar })
            .pipe(takeUntil(this.unsubscribe$))
            .subscribe((response) => this.dialogRef.close(response), (error) => this.snackBarService.showErrorMessage(error));
    }

    private validateData() {
      this.form = this.formBuilder.group(
        {
          userName: [
            this.userName,
            [
              Validators.required,
              Validators.minLength(3),
              Validators.maxLength(20)
            ]
          ],
          email: [
            this.email, 
            [
              Validators.required, 
              Validators.email, 
              Validators.pattern('^[a-z0-9._%+-]+@[a-z0-9.-]+\\.[a-z]{2,4}$')
            ]],
          password: [
            this.password,
            [
              Validators.required,
              Validators.minLength(6),
              Validators.maxLength(40)
            ]
          ]
        }
      );
    }

    private onSubmit(): void {
      this.submitted = true;
  
      if (this.form.invalid) {
        return;
      }
    }
}
