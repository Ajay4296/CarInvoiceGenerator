import React, {Component} from 'react';
import {InchToFeet,FeetToInch} from '../Components/Connection';
 class Length extends Component{
    constructor(props){
        super(props);
        this.state = {
            option:'',
            input:'',
            result:''
        };
    }

        handleOnOption = (event) => {
            this.setState({ option: event.target.value });
            console.log(this.state.option);
        }

        handleLengthChang = (event) => {
            this.setState({ input: event.target.value });
            console.log(this.state.input);
        }
    
        componentDidUpdate(){
        if(this.state.option=== 'Inch' && this.state.option!== 'Feet')
        InchToFeet(this.state.input).then(response => {
            this.setState({result:response.data})
            console.log(response.data); 
        })

        .catch((err) => {
            console.log("error while converting Inch to feet----------", err);
        });

        if(this.state.option!== 'Inch' && this.state.option=== 'Feet')
        FeetToInch(this.state.input).then(response => {
            this.setState({result:response.data})
            console.log(response.data);
        }).catch((err) => {
            console.log("error while converting feet to----------", err);
        });
    }
        render() {
            return (
                <div>
                
            <input type="number" className="input" onChange={this.handleLengthChang } />
            <select className="SelectItems" name="converter"  onClick={this.handleOnOption}>
            <option value="Feet">feet</option>
            <option value="Inch">inch</option>
            </select>
             
            <div className="equal">=</div>
            <div>
                <input type="number" className="input" value={this.state.result} />
                <select className="SelectItems">
                <option value="Inch"> Inch</option>
                    <option value="Feet">Feet</option>
                   
                </select>
            </div>
             </div>       
            );
        };
    }

export default Length;