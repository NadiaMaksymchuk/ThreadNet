import { Component, Inject } from '@angular/core';
import { MatDialogRef, MAT_DIALOG_DATA } from '@angular/material/dialog';
import { Reaction } from 'src/app/models/reactions/reaction';
import { User } from 'src/app/models/user';
import { PostComponent } from '../post/post.component';

@Component({
  selector: 'app-show-reactions-dialog',
  templateUrl: './show-reactions-dialog.component.html',
  styleUrls: ['./show-reactions-dialog.component.sass']
})
export class ShowReactionsDialogComponent {

  constructor(
    public dialogRef: MatDialogRef<PostComponent>,
    @Inject(MAT_DIALOG_DATA) public data: Reaction[]
    ) { }

  onNoClick(): void {
    this.dialogRef.close();
  }
}
