import EditorJS from './editorjs.mjs';

const initalData = document.getElementById('editor-data').attributes['value'];

const editor = new EditorJS({
    holderId: 'editorjs',
    data: JSON.parse(initalData)
});

window.editor = editor;

window.save = () => {
    editor.save().then((outputData) => {
        // TODO: Save data to server
       console.log(outputData)
    })
}