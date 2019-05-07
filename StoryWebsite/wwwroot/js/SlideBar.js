class SlideBar extends React.Component {
    constructor(props) {  
        super();  
        this.state = {
            sid: props.slide.id,
            slide: props.slide,
            title: props.slide.title,
            description: props.slide.description,
            imgURL: props.slide.imgURL,
            img: ""
        };
    } 

    updateTitle = (event) => {
            this.props.updateTitleHandler(this.state.sid, event.target.value);
            //this.setState({
            //        title: event.target.value
            //   });
    }

    updateDescription = (event) => {
            this.props.updateDescriptionHandler(this.state.sid, event.target.value);
            //this.setState({
            //        description: event.target.value
            //    });
    }

    updateimgURL = (url) => {
            this.props.updateImgURLHandler(this.state.sid, url);
    }
    //updateImg

    upload = (file) => {
          var formData  = new FormData();
          formData.append("file", file);

          fetch('/api/user/uploadImg', { // Your POST endpoint
            method: 'POST',
            body: formData // This is your file object
          }).then(
            response => response.json() // if the response is a JSON object
          ).then(
            success => { // Handle the success response object
                this.updateimgURL(success.newURL);
                //this.props.updateImgURLHandler(this.state.sid, success.newURL);
            }
          ).catch(
            error => console.log(error) // Handle the error response object
          );
    }

    onSelectFile = () => {
            //console.log(event.target.files[0]);
            this.upload(event.target.files[0]);
            //this.setState({
                //img: event.target.value
            //    });
    }


   
    componentWillReceiveProps(nextProps) {
        this.setState({ sid : nextProps.slide.id,
                        title: nextProps.slide.title,
                        description: nextProps.slide.description,
                        imgURL: nextProps.slide.imgURL,
                        slide: nextProps.slide
                       });
    }

    render() { 
        var sid = this.state.sid;
        return (
                 <div className = "SlideEntry-Wrap">
                    <div className = "SlideRow">
                        <div className = "SlideRow-Count">
                            <span>{sid}</span>
                            <button className = "remove SlideRow-Count" id = "remove" onClick = {() => this.props.removeHandler(this.state.sid)}><i className="far fa-trash-alt"></i></button>
                        </div>
                        <div className = "SlideRow-Img">
                            <img src = {this.state.imgURL}></img>
                        </div>
                        <div className = "SlideRow-Options">
                                 Title: <br/>
                                 <input className = "input-title" onChange = {this.updateTitle} value = {this.state.title}></input><br/> 
                                 Description: <br/> 
                                 <textarea rows="3" cols="50" className = "input-description" onChange = {this.updateDescription} value = {this.state.description}></textarea>
                        </div>
                        <div className = "SlideRow-Buttons">
                                <button className = "moveUp" onClick = {() => this.props.moveUpHandler(this.state.sid)}><i className="fas fa-chevron-up"></i></button>
                                <button className = "moveDown" onClick = {() => this.props.moveDownHandler(this.state.sid)}><i className="fas fa-chevron-down"></i></button>
                                <button className = "uploadImage" onClick = {() => {var input = document.getElementById("inputfile"); input.click()}}><i className="fas fa-image"></i></button>
                                <input id = "inputfile" type="file" onChange = {this.onSelectFile}></input>
                        </div>
                    </div>
                </div>
        );
    }
}