tree grammar tikztreegrammar;

options {
language = 'CSharp';
 tokenVocab=tikzgrammar;
 ASTLabelType=CommonTree;
}

@header { using GraphToTIKZ; }

@members { TikzGraph tres = new TikzGraph(); }

