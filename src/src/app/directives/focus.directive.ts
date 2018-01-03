import { Directive, ElementRef, Renderer, OnInit } from "@angular/core";

@Directive({ selector: '[tmFocus]' })

export class myFocus implements OnInit {
    constructor(private el: ElementRef, private renderer: Renderer) {
        // focus won't work at construction time - too early
    }

    ngOnInit() {
        this.renderer.invokeElementMethod(this.el.nativeElement, 'focus', []);
    }
}