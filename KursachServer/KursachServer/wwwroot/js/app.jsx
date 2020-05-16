class Hello extends React.Component {
    constructor(props) {
        super(props);
    }
    render() {
        return <h1>Hello Artick</h1>;
    }
}

ReactDOM.render(
    <Hello />,
    document.getElementById("content")
);